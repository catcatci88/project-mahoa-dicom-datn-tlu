using Dicom;
using Dicom.IO.Buffer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dicom.Imaging;
using Dicom.Imaging.Codec;
using System.IO;
using System.Security.Cryptography;
using EncodeforDicoms;

namespace EncodeforDicom
{
    public partial class EncodeDicom : Form
    {
        private DicomFile _file;
        public EncodeDicom()
        {
            InitializeComponent();
        }
        private void Reset()
        {

            lvDicom.Items.Clear();
            //menuItemView.Enabled = false;
            //menuItemAnonymize.Enabled = false;
        }
        private delegate void AddItemDelegate(string tag, string vr, string length, string value);
        private void AddItem(string tag, string vr, string length, string value)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new AddItemDelegate(AddItem), tag, vr, length, value);
                return;
            }

            var lvi = lvDicom.Items.Add(tag);
            lvi.SubItems.Add(vr);
            lvi.SubItems.Add(length);
            lvi.SubItems.Add(value);
        }
        private bool IsStructuredReport => _file != null
                                           && _file.Dataset.TryGetSingleValue(DicomTag.SOPClassUID, out DicomUID dummy)
                                           && dummy.StorageCategory == DicomStorageCategory.StructuredReport;

        public void OpenFile(string fileName)
        {
            DicomFile file;
            try
            {
                file = DicomFile.Open(fileName);
            }
            catch (DicomFileException ex)
            {
                file = ex.File;
                MessageBox.Show(
                    this,
                    "Exception while loading DICOM file: " + ex.Message,
                    "Error loading DICOM file",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (file != null) OpenFile(file);
        }
        public void OpenFile(DicomFile file)
        {
            try
            {
                lvDicom.BeginUpdate();

                Reset();

                _file = file;

                new DicomDatasetWalker(_file.FileMetaInfo).Walk(new DumpWalker(this));
                new DicomDatasetWalker(_file.Dataset).Walk(new DumpWalker(this));

                if (_file.Dataset.Contains(DicomTag.PixelData) || IsStructuredReport)
                {
                    //menuItemView.Enabled = true;
                    //menuItemAnonymize.Enabled = true;
                }
                //menuItemSyntax.Enabled = true;
                //menuItemSave.Enabled = true;

                //menuItemJpegLossy.Enabled = _file.Dataset.GetSingleValueOrDefault(DicomTag.BitsStored, 16) <= 12;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "Exception while loading DICOM file: " + ex.Message,
                    "Error loading DICOM file",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                lvDicom.EndUpdate();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (var ofd = new OpenFileDialog { Filter = "DICOM Files (*.dcm;*.dic)|*.dcm;*.dic|All Files (*.*)|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.Cancel) return;

                OpenFile(ofd.FileName);
                saveToolStripMenuItem.Enabled = true;
                viewImageDicomToolStripMenuItem.Enabled = true;
                exportToJPGToolStripMenuItem.Enabled = true;
                changeSystaxToolStripMenuItem.Enabled = true;
                maHoaToolStripMenuItem.Enabled = true;
                giaiMaToolStripMenuItem.Enabled = true;
            }

        }
        private string Indent { get; set; }
        public EncodeDicom Form { get; set; }
        public bool OnFragmentItem(IByteBuffer item)
        {
            if (item != null)
            {
                var tag = $"{Indent}Fragment";
                Form.AddItem(tag, string.Empty, item.Size.ToString(), string.Empty);
            }
            return true;
        }
        private class DumpWalker : IDicomDatasetWalker
        {
            private int _level = 0;

            public DumpWalker(EncodeDicom form)
            {
                Form = form;
                Level = 0;
            }

            public EncodeDicom Form { get; set; }

            public int Level
            {
                get => _level;
                set
                {
                    _level = value;
                    Indent = string.Empty.PadLeft(4 * _level);
                }
            }

            private string Indent { get; set; }

            public void OnBeginWalk()
            {
            }

            public bool OnElement(DicomElement element)
            {
                var tag = string.Format(
                    "{0}{1}  {2}",
                    Indent,
                    element.Tag.ToString().ToUpperInvariant(),
                    element.Tag.DictionaryEntry.Name);

                string value = "<large value not displayed>";
                if (element.Length <= 2048) value = string.Join("\\", element.Get<string[]>());

                if (element.ValueRepresentation == DicomVR.UI && element.Count > 0)
                {
                    var uid = element.Get<DicomUID>(0);
                    var name = uid.Name;
                    if (name != "Unknown") value = $"{value} ({name})";
                }

                Form.AddItem(tag, element.ValueRepresentation.Code, element.Length.ToString(), value);
                return true;
            }

#if !NET35
            public Task<bool> OnElementAsync(DicomElement element)
            {
                return Task.FromResult(OnElement(element));
            }
#endif

            public bool OnBeginSequence(DicomSequence sequence)
            {
                var tag = string.Format(
                    "{0}{1}  {2}",
                    Indent,
                    sequence.Tag.ToString().ToUpperInvariant(),
                    sequence.Tag.DictionaryEntry.Name);

                Form.AddItem(tag, "SQ", string.Empty, string.Empty);

                Level++;
                return true;
            }

            public bool OnBeginSequenceItem(DicomDataset dataset)
            {
                var tag = $"{Indent}Sequence Item:";

                Form.AddItem(tag, string.Empty, string.Empty, string.Empty);

                Level++;
                return true;
            }

            public bool OnEndSequenceItem()
            {
                Level--;
                return true;
            }

            public bool OnEndSequence()
            {
                Level--;
                return true;
            }

            public bool OnBeginFragment(DicomFragmentSequence fragment)
            {
                var tag = string.Format(
                    "{0}{1}  {2}",
                    Indent,
                    fragment.Tag.ToString().ToUpperInvariant(),
                    fragment.Tag.DictionaryEntry.Name);

                Form.AddItem(tag, fragment.ValueRepresentation.Code, string.Empty, string.Empty);

                Level++;
                return true;
            }

            public bool OnFragmentItem(IByteBuffer item)
            {
                if (item != null)
                {
                    var tag = $"{Indent}Fragment";

                    Form.AddItem(tag, string.Empty, item.Size.ToString(), string.Empty);
                }
                return true;
            }


#if !NET35
            public Task<bool> OnFragmentItemAsync(IByteBuffer item)
            {
                return Task.FromResult(OnFragmentItem(item));
            }
#endif

            public bool OnEndFragment()
            {
                Level--;
                return true;
            }

            public void OnEndWalk()
            {
            }

        }
        private void viewImageDicomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsStructuredReport)
            {
                var form = new ReportForm(_file);
                form.ShowDialog(this);
            }
            else
            {
                var form = new DisplayForm(_file);
                form.ShowDialog(this);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog
            {
                Filter = "DICOM (*.dcm)|*.dcm|Image (*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.gif"
            })
            {
                if (sfd.ShowDialog() == DialogResult.Cancel) return;

                if (sfd.FilterIndex == 1)
                {
                    var file = new DicomFile(_file.Dataset);
                    file.Save(sfd.FileName);
                }
                else
                {
                    var image = new DicomImage(_file.Dataset);
                    image.RenderImage().As<Image>().Save(sfd.FileName);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = _file.Clone();
            string studyUID = data.Dataset.GetSingleValueOrDefault(DicomTag.StudyInstanceUID, ""); // get value filed from dicom tag
            string pPatientID = data.Dataset.GetSingleValueOrDefault(DicomTag.PatientID, "");
            string paName = data.Dataset.GetSingleValueOrDefault(DicomTag.PatientName, "");
            string pStudyDescription = data.Dataset.GetSingleValueOrDefault(DicomTag.StudyDescription, "");
            //string pPatientBirthDate = data.Dataset.GetSingleValueOrDefault(DicomTag.PatientBirthDate , "");
            string pInstitutionName = data.Dataset.GetSingleValueOrDefault(DicomTag.InstitutionName, "");
            string pInstitutionAddress = data.Dataset.GetSingleValueOrDefault(DicomTag.InstitutionAddress, "");
            if (paName != "" && pInstitutionName != "" && pInstitutionAddress != "" && pPatientID != "")
            {
                //var a = Encode(studyUID + "vrpacs-key", pStudyDescription).Length;
                data.Dataset.AddOrUpdate(DicomTag.PatientID, Encode(studyUID + "vrpacs-key", pPatientID));
                data.Dataset.AddOrUpdate(DicomTag.PatientName, Encode(studyUID + "vrpacs-key", paName));
                data.Dataset.AddOrUpdate(DicomTag.InstitutionName, Encode(studyUID + "vrpacs-key", pInstitutionName));
                data.Dataset.AddOrUpdate(DicomTag.InstitutionAddress, Encode(studyUID + "vrpacs-key", pInstitutionAddress));
            }
            data.Dataset.AddOrUpdate(new DicomTag(0x00f, 0x7ffe), "vrpacs-encode");
            OpenFile(data);
            MessageBox.Show($"Ban da ma hoa du lieu anh thanh cong");
           
        }
        static String Encode(string key, string text)
        {
            Byte[] salt = Encoding.UTF8.GetBytes(key);
            HashAlgorithm algorithm = new SHA256CryptoServiceProvider();

            Byte[] saltedInput = new Byte[salt.Length];
            salt.CopyTo(saltedInput, 0);

            Byte[] hashedBytes = algorithm.ComputeHash(saltedInput);
            Byte[] res = EncryptOrDecrypt(Encoding.UTF8.GetBytes(text), hashedBytes);
            var base64 = System.Convert.ToBase64String(res); // convert sang base 64
            return base64;
        }

        static String Decode(string key, string text)
        {
            Byte[] salt = Encoding.UTF8.GetBytes(key);
            HashAlgorithm algorithm = new SHA256CryptoServiceProvider();

            Byte[] saltedInput = new Byte[salt.Length];
            salt.CopyTo(saltedInput, 0);

            Byte[] hashedBytes = algorithm.ComputeHash(saltedInput);
            Byte[] res = EncryptOrDecrypt(System.Convert.FromBase64String(text), hashedBytes);
            string s = Encoding.UTF8.GetString(res);
            return s;
        }

        static Byte[] EncryptOrDecrypt(Byte[] text, Byte[] key) // convert sang byte -> đảo bit của từng byte
        {
            Byte[] res = new Byte[text.Length];
            for (int c = 0; c < text.Length; c++)
            {
                uint keyCode = key[c % 32];
                uint combinedCode = text[c] ^ keyCode;
                res[c] = (byte)combinedCode;
                char combinedChar = (char)combinedCode;
            }

            return res;
        }

        private void giaiMaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data1 = _file.Clone();
            bool checkEncode = data1.Dataset.GetSingleValueOrDefault(new DicomTag(0x00f, 0x7ffe), "") == "vrpacs-encode" ? true : false;
            if (checkEncode)
            {
                string studyUID1 = data1.Dataset.GetSingleValueOrDefault(DicomTag.StudyInstanceUID, "");
                string pPatientID_decryption = data1.Dataset.GetSingleValueOrDefault(DicomTag.PatientID, "");
                string paName_decryption = data1.Dataset.GetSingleValueOrDefault(DicomTag.PatientName, "");
                string pStudyDescription_decryption = data1.Dataset.GetSingleValueOrDefault(DicomTag.StudyDescription, "");
                string pInstitutionName_decryption = data1.Dataset.GetSingleValueOrDefault(DicomTag.InstitutionName, "");
                string pInstitutionAddress_decryption = data1.Dataset.GetSingleValueOrDefault(DicomTag.InstitutionAddress, "");
                if (paName_decryption != "" && pInstitutionName_decryption != "" && pInstitutionAddress_decryption != "" && pPatientID_decryption != "")
                {
                    //var a = Decode("vrpacs-key", pPatientID_decryption);
                    data1.Dataset.AddOrUpdate(DicomTag.PatientID, Decode(studyUID1 + "vrpacs-key", pPatientID_decryption));
                    data1.Dataset.AddOrUpdate(DicomTag.PatientName, Decode(studyUID1 + "vrpacs-key", paName_decryption));
                    //data1.Dataset.AddOrUpdate(DicomTag.StudyDescription, EncodeOrDecode("mahoa", pStudyDescription));
                    //data1.Dataset.AddOrUpdate(DicomTag.PatientBirthDate, EncodeOrDecode("mahoa", pPatientBirthDate_decryption));
                    data1.Dataset.AddOrUpdate(DicomTag.InstitutionName, Decode(studyUID1 + "vrpacs-key", pInstitutionName_decryption));
                    data1.Dataset.AddOrUpdate(DicomTag.InstitutionAddress, Decode(studyUID1 + "vrpacs-key", pInstitutionAddress_decryption));
                }
                OpenFile(data1);
                MessageBox.Show($"Ban da giai ma du lieu anh thanh cong");
            }
        }

        private void exportToJPGToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var sfd = new SaveFileDialog
            {
                Filter = "Image (*.jpg;)|*.jpg;"
            })
            {
                if (sfd.ShowDialog() == DialogResult.Cancel) return;

                if (sfd.FilterIndex == 0)
                {
                    var file = new DicomFile(_file.Dataset);
                    file.Save(sfd.FileName);
                }
                else
                {
                    var image = new DicomImage(_file.Dataset);
                    image.RenderImage().As<Image>().Save(sfd.FileName);
                }
            }

        }
        private void ChangeSyntax(DicomTransferSyntax syntax, DicomCodecParams param = null)
        {
            var file = _file.Clone(syntax, param);
            OpenFile(file);
        }
        private void explicitVRLittleEndianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.ExplicitVRLittleEndian);
        }

        private void implicitVRLittleEndianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.ImplicitVRLittleEndian);
        }

        private void explicitVRBigEndianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.ExplicitVRBigEndian);
        }

        private void jPEGLosslessP14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.JPEGProcess14);
        }

        private void jPEGLosslessP14SV1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.JPEGProcess14SV1);
        }

        private void quality100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bits = _file.Dataset.GetSingleValueOrDefault(DicomTag.BitsAllocated, 8);
            var syntax = DicomTransferSyntax.JPEGProcess1;
            if (bits == 16) syntax = DicomTransferSyntax.JPEGProcess2_4;
            ChangeSyntax(syntax, new DicomJpegParams { Quality = 100 });
        }

        private void quality100ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var bits = _file.Dataset.GetSingleValueOrDefault(DicomTag.BitsAllocated, 8);
            var syntax = DicomTransferSyntax.JPEGProcess1;
            if (bits == 16) syntax = DicomTransferSyntax.JPEGProcess2_4;
            ChangeSyntax(syntax, new DicomJpegParams { Quality = 90 });
        }

        private void jPEG2000LosslessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.JPEG2000Lossless);
        }

        private void rate5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.JPEG2000Lossy, new DicomJpeg2000Params { Rate = 5 });
        }

        private void rate10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.JPEG2000Lossy, new DicomJpeg2000Params { Rate = 10 });
        }

        private void rate20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.JPEG2000Lossy, new DicomJpeg2000Params { Rate = 20 });
        }

        private void rate40ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.JPEG2000Lossy, new DicomJpeg2000Params { Rate = 40 });
        }

        private void rate80ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.JPEG2000Lossy, new DicomJpeg2000Params { Rate = 80 });
        }

        private void jPEGLSLosslessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.JPEGLSLossless);
        }

        private void rLELosslessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSyntax(DicomTransferSyntax.RLELossless);
        }

        public void LoadGridKeyword()
        {
            lvDicom.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lvDicom.Clear();
            AddItem(boxSearch.Text, "", "", "");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadGridKeyword();
        }

        private void showDicomTagToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lvDicom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

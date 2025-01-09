// This project uses OpenCvSharp and OpenCV, which is licensed under the MIT License and Apache License 2.0. See LICENSE file for more details.

using System;
using System.Drawing;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using System.Resources;
using OpenCvSharp;

namespace Look_alike_Judging
{
    public partial class Form1 : Form
    {
        private Mat image1 = new Mat();
        private Mat image2 = new Mat();
        private CascadeClassifier faceCascade;

        public Form1()
        {
            InitializeComponent();

            faceCascade = new CascadeClassifier(AppDomain.CurrentDomain.BaseDirectory + "Resources\\haarcascade_frontalface_default.xml");

            // PictureBox �̃h���b�O�h���b�v��ݒ�
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox1.DragDrop += PictureBox1_DragDrop;
            pictureBox2.DragDrop += PictureBox2_DragDrop;
            pictureBox1.DragEnter += PictureBox_DragEnter;
            pictureBox2.DragEnter += PictureBox_DragEnter;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        // �摜�P�ǉ��{�^��
        private void buttonBrowse_Click1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "�摜�t�@�C�� (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadImageToPictureBox(openFileDialog.FileName, pictureBox1, ref image1);
                }
            }
        }

        // �摜�Q�ǉ��{�^��
        private void buttonBrowse_Click2(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "�摜�t�@�C�� (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadImageToPictureBox(openFileDialog.FileName, pictureBox2, ref image2);
                }
            }
        }

        // �摜�P�h���b�O���h���b�v����
        private void PictureBox1_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0)
            {
                LoadImageToPictureBox(files[0], pictureBox1, ref image1);
            }
            else
            {
                MessageBox.Show("�t�@�C���̃h���b�v�������ł��B");
            }
        }

        // �摜�Q�h���b�O���h���b�v����
        private void PictureBox2_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0)
            {
                LoadImageToPictureBox(files[0], pictureBox2, ref image2);
            }
            else
            {
                MessageBox.Show("�t�@�C���̃h���b�v�������ł��B");
            }
        }

        //�h���b�O���h���b�v����
        private void PictureBox_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // �������肳�񔻒�J�n�{�^��
        private void judgingButton_Click(object sender, EventArgs e)
        {
            if (image1.Empty() || image2.Empty())
            {
                MessageBox.Show("�����̉摜��ǂݍ���ł��������B");
                return;
            }

            // ��F���Ɣ�r
            var faces1 = DetectFaces(image1);
            var faces2 = DetectFaces(image2);

            if (faces1.Length == 0 || faces2.Length == 0)
            {
                MessageBox.Show("�炪���o����܂���ł����B");
                return;
            }

            // �ގ��x�v�Z
            double similarity = CompareFaces(image1, faces1[0], image2, faces2[0]);

            label_result_per.Text = $"{similarity * 100:0.00}% �ł��B";
        }

        // �摜�̓ǂݍ��݂ƕϊ�
        private void LoadImageToPictureBox(string filePath, PictureBox pictureBox, ref Mat image)
        {
            image = Cv2.ImRead(filePath);  // �摜��ǂݍ���
            pictureBox.Image = OpenCvSharpExtensions.ToBitmap(image);  // �蓮�ŕϊ�
        }

        // ������o���ăO���[�X�P�[���ɕϊ�
        private Rect[] DetectFaces(Mat image)
        {
            var gray = new Mat();
            Cv2.CvtColor(image, gray, ColorConversionCodes.BGR2GRAY);

            // �猟�o�̂��߂̃I�v�V������ύX
            return faceCascade.DetectMultiScale(gray, 1.1, 4, 0, new OpenCvSharp.Size(30, 30));
        }

        // ����r
        private double CompareFaces(Mat img1, Rect face1, Mat img2, Rect face2)
        {
            // �畔���̐؂�o��
            var faceImg1 = new Mat(img1, face1);
            var faceImg2 = new Mat(img2, face2);

            // �T�C�Y�𑵂���
            var resized1 = new Mat();
            var resized2 = new Mat();
            Cv2.Resize(faceImg1, resized1, new OpenCvSharp.Size(100, 100));
            Cv2.Resize(faceImg2, resized2, new OpenCvSharp.Size(100, 100));

            // ���T�C�Y�����摜���O���[�X�P�[���ɕϊ�
            var gray1 = new Mat();
            var gray2 = new Mat();
            Cv2.CvtColor(resized1, gray1, ColorConversionCodes.BGR2GRAY);
            Cv2.CvtColor(resized2, gray2, ColorConversionCodes.BGR2GRAY);

            // �q�X�g�O�����̌v�Z
            Mat hist1 = new Mat();
            Mat hist2 = new Mat();
            Cv2.CalcHist(new[] { gray1 }, new[] { 0 }, null, hist1, 1, new[] { 256 }, new[] { new Rangef(0, 256) });
            Cv2.CalcHist(new[] { gray2 }, new[] { 0 }, null, hist2, 1, new[] { 256 }, new[] { new Rangef(0, 256) });

            // �q�X�g�O�����̔�r�i�R�T�C���ގ��x�j
            double similarity = Cv2.CompareHist(hist1, hist2, HistCompMethods.Correl);
            return similarity;
        }
    }

    // OpenCvSharp �̊g�����\�b�h���`
    public static class OpenCvSharpExtensions
    {
        // Mat �� Bitmap �ɕϊ�����
        public static Bitmap ToBitmap(Mat mat)
        {
            byte[] imageBytes;
            Cv2.ImEncode(".jpg", mat, out imageBytes); // �C���ӏ�

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return new Bitmap(ms);
            }
        }
    }
}

namespace MyBusinessCard
{
    public partial class Form1 : Form
    {
        private System.Drawing.Image originalImage;
        private bool isAlternateImage = false;

        public Form1()
        {
            InitializeComponent();
            // 초기 표시된 이미지를 저장하여 토글 시 복원할 수 있게 함
            originalImage = pictureBox1.Image;

            // 마우스 효과 이벤트 연결
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            // 0~255 사이의R, G, B 값을무작위로생성하여배경색에적용
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/alaskagom",
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 사진을 토글: 현재가 기본이면 리소스 이미지로 바꾸고, 아니면 원래 이미지로 복원
            if (!isAlternateImage)
            {
                pictureBox1.Image = Properties.Resources.images;
            }
            else
            {
                pictureBox1.Image = originalImage;
            }

            isAlternateImage = !isAlternateImage;
        }

        // 마우스가 사진 위로 올라갈 때 테두리 스타일 적용
        private void pictureBox1_MouseEnter(object? sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        // 마우스가 사진에서 벗어날 때 원래 테두리(없음)로 복원
        private void pictureBox1_MouseLeave(object? sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }
    }
}

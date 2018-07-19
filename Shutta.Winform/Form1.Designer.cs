namespace Shutta.Winform
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRound = new System.Windows.Forms.Button();
            this.ptb11 = new System.Windows.Forms.PictureBox();
            this.lblMoney1 = new System.Windows.Forms.Label();
            this.ptb10 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptb01 = new System.Windows.Forms.PictureBox();
            this.lblMoney0 = new System.Windows.Forms.Label();
            this.ptb00 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb10)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb00)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(243, 12);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(75, 23);
            this.btnRound.TabIndex = 5;
            this.btnRound.Text = "&Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // ptb11
            // 
            this.ptb11.Location = new System.Drawing.Point(106, 20);
            this.ptb11.Name = "ptb11";
            this.ptb11.Size = new System.Drawing.Size(94, 122);
            this.ptb11.TabIndex = 1;
            this.ptb11.TabStop = false;
            // 
            // lblMoney1
            // 
            this.lblMoney1.Location = new System.Drawing.Point(6, 145);
            this.lblMoney1.Name = "lblMoney1";
            this.lblMoney1.Size = new System.Drawing.Size(194, 23);
            this.lblMoney1.TabIndex = 2;
            this.lblMoney1.Text = "label2";
            this.lblMoney1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptb10
            // 
            this.ptb10.Location = new System.Drawing.Point(6, 20);
            this.ptb10.Name = "ptb10";
            this.ptb10.Size = new System.Drawing.Size(94, 122);
            this.ptb10.TabIndex = 0;
            this.ptb10.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptb10);
            this.groupBox2.Controls.Add(this.lblMoney1);
            this.groupBox2.Controls.Add(this.ptb11);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 177);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "P1";
            // 
            // ptb01
            // 
            this.ptb01.Location = new System.Drawing.Point(106, 20);
            this.ptb01.Name = "ptb01";
            this.ptb01.Size = new System.Drawing.Size(94, 122);
            this.ptb01.TabIndex = 1;
            this.ptb01.TabStop = false;
            // 
            // lblMoney0
            // 
            this.lblMoney0.Location = new System.Drawing.Point(6, 145);
            this.lblMoney0.Name = "lblMoney0";
            this.lblMoney0.Size = new System.Drawing.Size(194, 23);
            this.lblMoney0.TabIndex = 2;
            this.lblMoney0.Text = "label1";
            this.lblMoney0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptb00
            // 
            this.ptb00.Location = new System.Drawing.Point(6, 20);
            this.ptb00.Name = "ptb00";
            this.ptb00.Size = new System.Drawing.Size(94, 122);
            this.ptb00.TabIndex = 0;
            this.ptb00.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptb00);
            this.groupBox1.Controls.Add(this.lblMoney0);
            this.groupBox1.Controls.Add(this.ptb01);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "P0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 396);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb10)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb00)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.PictureBox ptb11;
        private System.Windows.Forms.Label lblMoney1;
        private System.Windows.Forms.PictureBox ptb10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ptb01;
        private System.Windows.Forms.Label lblMoney0;
        private System.Windows.Forms.PictureBox ptb00;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


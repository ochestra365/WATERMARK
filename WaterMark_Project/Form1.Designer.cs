
namespace WaterMark_Project
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
            this.BtnExport = new System.Windows.Forms.Button();
            this.TxtWaterMark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOpacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtrotation = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // BtnExport
            // 
            this.BtnExport.Font = new System.Drawing.Font("굴림", 30F);
            this.BtnExport.Location = new System.Drawing.Point(304, 429);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(349, 97);
            this.BtnExport.TabIndex = 0;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // TxtWaterMark
            // 
            this.TxtWaterMark.Location = new System.Drawing.Point(103, 84);
            this.TxtWaterMark.Name = "TxtWaterMark";
            this.TxtWaterMark.Size = new System.Drawing.Size(213, 21);
            this.TxtWaterMark.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "SIZE : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "TEXT : ";
            // 
            // TxtSize
            // 
            this.TxtSize.Location = new System.Drawing.Point(103, 29);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(213, 21);
            this.TxtSize.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Opacity : ";
            // 
            // TxtOpacity
            // 
            this.TxtOpacity.Location = new System.Drawing.Point(114, 128);
            this.TxtOpacity.Name = "TxtOpacity";
            this.TxtOpacity.Size = new System.Drawing.Size(213, 21);
            this.TxtOpacity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rotation : ";
            // 
            // Txtrotation
            // 
            this.Txtrotation.Location = new System.Drawing.Point(114, 178);
            this.Txtrotation.Name = "Txtrotation";
            this.Txtrotation.Size = new System.Drawing.Size(213, 21);
            this.Txtrotation.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 538);
            this.Controls.Add(this.Txtrotation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtOpacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtWaterMark);
            this.Controls.Add(this.BtnExport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.TextBox TxtWaterMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOpacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtrotation;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}


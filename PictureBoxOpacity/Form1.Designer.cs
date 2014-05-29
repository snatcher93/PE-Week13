namespace PictureBoxWeakness
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.beeTimer = new System.Windows.Forms.Timer(this.components);
            this.beeCtrl = new System.Windows.Forms.PictureBox();
            this.beeCtrl2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.beeCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beeCtrl2)).BeginInit();
            this.SuspendLayout();
            // 
            // beeTimer
            // 
            this.beeTimer.Enabled = true;
            this.beeTimer.Tick += new System.EventHandler(this.beeTimer_Tick);
            // 
            // beeCtrl
            // 
            this.beeCtrl.BackColor = System.Drawing.Color.Transparent;
            this.beeCtrl.Location = new System.Drawing.Point(40, 23);
            this.beeCtrl.Name = "beeCtrl";
            this.beeCtrl.Size = new System.Drawing.Size(282, 251);
            this.beeCtrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.beeCtrl.TabIndex = 1;
            this.beeCtrl.TabStop = false;
            // 
            // beeCtrl2
            // 
            this.beeCtrl2.BackColor = System.Drawing.Color.Transparent;
            this.beeCtrl2.Location = new System.Drawing.Point(176, 174);
            this.beeCtrl2.Name = "beeCtrl2";
            this.beeCtrl2.Size = new System.Drawing.Size(277, 220);
            this.beeCtrl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.beeCtrl2.TabIndex = 2;
            this.beeCtrl2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 537);
            this.Controls.Add(this.beeCtrl2);
            this.Controls.Add(this.beeCtrl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.beeCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beeCtrl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer beeTimer;
        private System.Windows.Forms.PictureBox beeCtrl;
        private System.Windows.Forms.PictureBox beeCtrl2;
    }
}


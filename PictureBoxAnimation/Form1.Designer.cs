﻿namespace Week13
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
            this.beeCtrl = new System.Windows.Forms.PictureBox();
            this.beeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.beeCtrl)).BeginInit();
            this.SuspendLayout();
            // 
            // beeCtrl
            // 
            this.beeCtrl.BackColor = System.Drawing.Color.Transparent;
            this.beeCtrl.Location = new System.Drawing.Point(44, 37);
            this.beeCtrl.Name = "beeCtrl";
            this.beeCtrl.Size = new System.Drawing.Size(292, 270);
            this.beeCtrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.beeCtrl.TabIndex = 0;
            this.beeCtrl.TabStop = false;
            // 
            // beeTimer
            // 
            this.beeTimer.Enabled = true;
            this.beeTimer.Tick += new System.EventHandler(this.beeTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(393, 370);
            this.Controls.Add(this.beeCtrl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.beeCtrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox beeCtrl;
        private System.Windows.Forms.Timer beeTimer;
    }
}


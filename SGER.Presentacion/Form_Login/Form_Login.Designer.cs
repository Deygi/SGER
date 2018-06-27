namespace SGER.Presentacion.Form_Login
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BtonCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtonAcept = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(201, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 49;
            this.label1.Text = "LOGIN";
            // 
            // BtonCancelar
            // 
            this.BtonCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtonCancelar.BorderRadius = 0;
            this.BtonCancelar.ButtonText = "Cancelar";
            this.BtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtonCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.BtonCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtonCancelar.Iconimage = null;
            this.BtonCancelar.Iconimage_right = null;
            this.BtonCancelar.Iconimage_right_Selected = null;
            this.BtonCancelar.Iconimage_Selected = null;
            this.BtonCancelar.IconMarginLeft = 0;
            this.BtonCancelar.IconMarginRight = 0;
            this.BtonCancelar.IconRightVisible = true;
            this.BtonCancelar.IconRightZoom = 0D;
            this.BtonCancelar.IconVisible = true;
            this.BtonCancelar.IconZoom = 90D;
            this.BtonCancelar.IsTab = false;
            this.BtonCancelar.Location = new System.Drawing.Point(123, 323);
            this.BtonCancelar.Name = "BtonCancelar";
            this.BtonCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtonCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BtonCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtonCancelar.selected = false;
            this.BtonCancelar.Size = new System.Drawing.Size(256, 44);
            this.BtonCancelar.TabIndex = 48;
            this.BtonCancelar.Text = "Cancelar";
            this.BtonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtonCancelar.Textcolor = System.Drawing.Color.White;
            this.BtonCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonCancelar.Click += new System.EventHandler(this.BtonCancelar_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(223)))), ((int)(((byte)(208)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 34);
            this.panel1.TabIndex = 44;
            // 
            // BtonAcept
            // 
            this.BtonAcept.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtonAcept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(211)))), ((int)(((byte)(95)))));
            this.BtonAcept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtonAcept.BorderRadius = 0;
            this.BtonAcept.ButtonText = "Aceptar";
            this.BtonAcept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtonAcept.DisabledColor = System.Drawing.Color.Gray;
            this.BtonAcept.Iconcolor = System.Drawing.Color.Transparent;
            this.BtonAcept.Iconimage = null;
            this.BtonAcept.Iconimage_right = null;
            this.BtonAcept.Iconimage_right_Selected = null;
            this.BtonAcept.Iconimage_Selected = null;
            this.BtonAcept.IconMarginLeft = 0;
            this.BtonAcept.IconMarginRight = 0;
            this.BtonAcept.IconRightVisible = true;
            this.BtonAcept.IconRightZoom = 0D;
            this.BtonAcept.IconVisible = true;
            this.BtonAcept.IconZoom = 90D;
            this.BtonAcept.IsTab = false;
            this.BtonAcept.Location = new System.Drawing.Point(123, 258);
            this.BtonAcept.Name = "BtonAcept";
            this.BtonAcept.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(211)))), ((int)(((byte)(95)))));
            this.BtonAcept.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtonAcept.OnHoverTextColor = System.Drawing.Color.White;
            this.BtonAcept.selected = false;
            this.BtonAcept.Size = new System.Drawing.Size(256, 44);
            this.BtonAcept.TabIndex = 47;
            this.BtonAcept.Text = "Aceptar";
            this.BtonAcept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtonAcept.Textcolor = System.Drawing.Color.White;
            this.BtonAcept.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonAcept.Click += new System.EventHandler(this.BtonAcept_Click_1);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(123, 113);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(256, 40);
            this.txtUser.TabIndex = 45;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 181);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(256, 40);
            this.txtPassword.TabIndex = 46;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(501, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtonCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtonAcept);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BtonCancelar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtonAcept;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
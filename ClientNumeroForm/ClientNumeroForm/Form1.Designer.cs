
namespace ClientNumeroForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_response = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_danger = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(97, 44);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(224, 23);
            this.txt_number.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci un numero";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(166, 73);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 54);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Invia";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lbl_response
            // 
            this.lbl_response.AutoSize = true;
            this.lbl_response.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_response.Location = new System.Drawing.Point(164, 130);
            this.lbl_response.Name = "lbl_response";
            this.lbl_response.Size = new System.Drawing.Size(82, 21);
            this.lbl_response.TabIndex = 3;
            this.lbl_response.Text = "Risposta: ";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(143, 328);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(54, 23);
            this.txt_ip.TabIndex = 4;
            this.txt_ip.Text = "127.0.0.1";
            this.txt_ip.TextChanged += new System.EventHandler(this.txt_ip_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP del server (facoltativo)";
            // 
            // lbl_danger
            // 
            this.lbl_danger.AutoSize = true;
            this.lbl_danger.ForeColor = System.Drawing.Color.Red;
            this.lbl_danger.Location = new System.Drawing.Point(107, 357);
            this.lbl_danger.Name = "lbl_danger";
            this.lbl_danger.Size = new System.Drawing.Size(0, 15);
            this.lbl_danger.TabIndex = 6;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(219, 328);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(48, 23);
            this.txt_port.TabIndex = 7;
            this.txt_port.Text = "5000";
            this.txt_port.TextChanged += new System.EventHandler(this.txt_port_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_result.Location = new System.Drawing.Point(128, 184);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(133, 32);
            this.lbl_result.TabIndex = 9;
            this.lbl_result.Text = "In attesa...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 381);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.lbl_danger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.lbl_response);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_response;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_danger;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_result;
    }
}


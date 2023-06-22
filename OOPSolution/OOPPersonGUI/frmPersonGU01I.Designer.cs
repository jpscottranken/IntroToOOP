﻿namespace OOPPersonGUI
{
    partial class frmPersonGU01I
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
            this.btnInstantiate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEyeColor = new System.Windows.Forms.Label();
            this.lblHairColor = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtHairColor = new System.Windows.Forms.TextBox();
            this.txtEyeColor = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInstantiate
            // 
            this.btnInstantiate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstantiate.Location = new System.Drawing.Point(58, 616);
            this.btnInstantiate.Name = "btnInstantiate";
            this.btnInstantiate.Size = new System.Drawing.Size(204, 65);
            this.btnInstantiate.TabIndex = 8;
            this.btnInstantiate.Text = "Instantiate";
            this.btnInstantiate.UseVisualStyleBackColor = true;
            this.btnInstantiate.Click += new System.EventHandler(this.btnInstantiate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(331, 616);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(204, 65);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(594, 616);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(204, 65);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Lime;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFirstName.Location = new System.Drawing.Point(89, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(297, 43);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Lime;
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastName.Location = new System.Drawing.Point(89, 112);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(297, 43);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEyeColor
            // 
            this.lblEyeColor.BackColor = System.Drawing.Color.Lime;
            this.lblEyeColor.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEyeColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEyeColor.Location = new System.Drawing.Point(89, 185);
            this.lblEyeColor.Name = "lblEyeColor";
            this.lblEyeColor.Size = new System.Drawing.Size(297, 43);
            this.lblEyeColor.TabIndex = 13;
            this.lblEyeColor.Text = "Eye Color:";
            this.lblEyeColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHairColor
            // 
            this.lblHairColor.BackColor = System.Drawing.Color.Lime;
            this.lblHairColor.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHairColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHairColor.Location = new System.Drawing.Point(89, 252);
            this.lblHairColor.Name = "lblHairColor";
            this.lblHairColor.Size = new System.Drawing.Size(297, 43);
            this.lblHairColor.TabIndex = 14;
            this.lblHairColor.Text = "Hair Color:";
            this.lblHairColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeight
            // 
            this.lblHeight.BackColor = System.Drawing.Color.Lime;
            this.lblHeight.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeight.Location = new System.Drawing.Point(89, 322);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(297, 43);
            this.lblHeight.TabIndex = 15;
            this.lblHeight.Text = "Height:";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.Color.Lime;
            this.lblWeight.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeight.Location = new System.Drawing.Point(89, 393);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(297, 43);
            this.lblWeight.TabIndex = 16;
            this.lblWeight.Text = "Weight:";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Lime;
            this.lblGender.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Location = new System.Drawing.Point(89, 462);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(297, 43);
            this.lblGender.TabIndex = 17;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.BackColor = System.Drawing.Color.Lime;
            this.lblMaritalStatus.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaritalStatus.Location = new System.Drawing.Point(89, 534);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(297, 43);
            this.lblMaritalStatus.TabIndex = 18;
            this.lblMaritalStatus.Text = "Marital Status:";
            this.lblMaritalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(407, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(391, 44);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(407, 393);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(391, 44);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(407, 322);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(391, 44);
            this.txtHeight.TabIndex = 4;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHairColor
            // 
            this.txtHairColor.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHairColor.Location = new System.Drawing.Point(407, 252);
            this.txtHairColor.Name = "txtHairColor";
            this.txtHairColor.Size = new System.Drawing.Size(391, 44);
            this.txtHairColor.TabIndex = 3;
            this.txtHairColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEyeColor
            // 
            this.txtEyeColor.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEyeColor.Location = new System.Drawing.Point(407, 185);
            this.txtEyeColor.Name = "txtEyeColor";
            this.txtEyeColor.Size = new System.Drawing.Size(391, 44);
            this.txtEyeColor.TabIndex = 2;
            this.txtEyeColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(407, 112);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(391, 44);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(407, 462);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(391, 44);
            this.txtGender.TabIndex = 6;
            this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaritalStatus.Location = new System.Drawing.Point(407, 534);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.Size = new System.Drawing.Size(391, 44);
            this.txtMaritalStatus.TabIndex = 7;
            this.txtMaritalStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPersonGUI
            // 
            this.AcceptButton = this.btnInstantiate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(869, 755);
            this.Controls.Add(this.txtMaritalStatus);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtEyeColor);
            this.Controls.Add(this.txtHairColor);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblMaritalStatus);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblHairColor);
            this.Controls.Add(this.lblEyeColor);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInstantiate);
            this.Name = "frmPersonGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWD1100 - Object-Oriented Programming (OOP) GUI Person App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstantiate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEyeColor;
        private System.Windows.Forms.Label lblHairColor;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtHairColor;
        private System.Windows.Forms.TextBox txtEyeColor;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtMaritalStatus;
    }
}


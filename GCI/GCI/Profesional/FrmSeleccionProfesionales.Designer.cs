﻿namespace GCI
{
    partial class FrmSeleccionProfesionales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionProfesionales));
            this.txt_nya_profesional = new System.Windows.Forms.TextBox();
            this.lb_profesional = new System.Windows.Forms.Label();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nya_profesional
            // 
            this.txt_nya_profesional.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nya_profesional.Location = new System.Drawing.Point(126, 16);
            this.txt_nya_profesional.Name = "txt_nya_profesional";
            this.txt_nya_profesional.Size = new System.Drawing.Size(371, 20);
            this.txt_nya_profesional.TabIndex = 0;
            this.txt_nya_profesional.TextChanged += new System.EventHandler(this.txt_nya_profesional_TextChanged);
            // 
            // lb_profesional
            // 
            this.lb_profesional.BackColor = System.Drawing.Color.Transparent;
            this.lb_profesional.Image = global::GCI.Properties.Resources.user_icon_16;
            this.lb_profesional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_profesional.Location = new System.Drawing.Point(16, 8);
            this.lb_profesional.Name = "lb_profesional";
            this.lb_profesional.Size = new System.Drawing.Size(104, 35);
            this.lb_profesional.TabIndex = 1;
            this.lb_profesional.Text = "Profesional:";
            this.lb_profesional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(16, 51);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.ReadOnly = true;
            this.dgv_datos.Size = new System.Drawing.Size(481, 358);
            this.dgv_datos.TabIndex = 2;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Image = global::GCI.Properties.Resources.round_checkmark_icon_16;
            this.btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_seleccionar.Location = new System.Drawing.Point(401, 421);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(96, 35);
            this.btn_seleccionar.TabIndex = 3;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::GCI.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(320, 421);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FrmSeleccionProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(509, 461);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.lb_profesional);
            this.Controls.Add(this.txt_nya_profesional);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeleccionProfesionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de Profesionales";
            this.Load += new System.EventHandler(this.FrmSeleccionProfesionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nya_profesional;
        private System.Windows.Forms.Label lb_profesional;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}
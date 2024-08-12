namespace Clientes
{
    partial class frm_Clientes
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
            btn_Grabar = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            btn_cancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_Detalle = new TextBox();
            lst_Cliente = new ListBox();
            SuspendLayout();
            // 
            // btn_Grabar
            // 
            btn_Grabar.Location = new Point(28, 355);
            btn_Grabar.Name = "btn_Grabar";
            btn_Grabar.Size = new Size(75, 23);
            btn_Grabar.TabIndex = 0;
            btn_Grabar.Text = "Grabar";
            btn_Grabar.UseVisualStyleBackColor = true;
            btn_Grabar.Click += btn_Grabar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(109, 355);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(75, 23);
            btn_modificar.TabIndex = 1;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click_1;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(200, 355);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(75, 23);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Cancelar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click_1;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(291, 355);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 114);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 72);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 5;
            label2.Text = "Lista de clientes";
            // 
            // txt_Detalle
            // 
            txt_Detalle.Location = new Point(41, 154);
            txt_Detalle.Name = "txt_Detalle";
            txt_Detalle.Size = new Size(100, 23);
            txt_Detalle.TabIndex = 6;
            // 
            // lst_Cliente
            // 
            lst_Cliente.FormattingEnabled = true;
            lst_Cliente.ItemHeight = 15;
            lst_Cliente.Location = new Point(250, 179);
            lst_Cliente.Name = "lst_Cliente";
            lst_Cliente.Size = new Size(120, 94);
            lst_Cliente.TabIndex = 7;
            // 
            // frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lst_Cliente);
            Controls.Add(txt_Detalle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_Grabar);
            Name = "frm_Clientes";
            Text = "Cliente";
            Load += frm_Clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Grabar;
        private Button btn_modificar;
        private Button btn_eliminar;
        private Button btn_cancelar;
        private Label label1;
        private Label label2;
        private TextBox txt_Detalle;
        private ListBox lst_Cliente;
    }
}

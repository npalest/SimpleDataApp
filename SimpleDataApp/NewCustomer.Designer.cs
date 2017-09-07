namespace SimpleDataApp
{
    partial class NewCustomer
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAddFinish = new System.Windows.Forms.Button();
            this.btnAddAnotherAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(131, 66);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(131, 106);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 1;
            // 
            // numOrderAmount
            // 
            this.numOrderAmount.Location = new System.Drawing.Point(131, 193);
            this.numOrderAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numOrderAmount.Name = "numOrderAmount";
            this.numOrderAmount.Size = new System.Drawing.Size(120, 20);
            this.numOrderAmount.TabIndex = 2;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(131, 231);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(401, 103);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(126, 23);
            this.btnCreateAccount.TabIndex = 4;
            this.btnCreateAccount.Text = "Crear Cuenta";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(401, 228);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(126, 23);
            this.btnPlaceOrder.TabIndex = 5;
            this.btnPlaceOrder.Text = "Realizar Pedido";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnAddFinish
            // 
            this.btnAddFinish.Location = new System.Drawing.Point(131, 334);
            this.btnAddFinish.Name = "btnAddFinish";
            this.btnAddFinish.Size = new System.Drawing.Size(75, 23);
            this.btnAddFinish.TabIndex = 6;
            this.btnAddFinish.Text = "Finalizar";
            this.btnAddFinish.UseVisualStyleBackColor = true;
            this.btnAddFinish.Click += new System.EventHandler(this.btnAddFinish_Click);
            // 
            // btnAddAnotherAccount
            // 
            this.btnAddAnotherAccount.Location = new System.Drawing.Point(401, 334);
            this.btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            this.btnAddAnotherAccount.Size = new System.Drawing.Size(126, 23);
            this.btnAddAnotherAccount.TabIndex = 7;
            this.btnAddAnotherAccount.Text = "Agregar otra Cuenta";
            this.btnAddAnotherAccount.UseVisualStyleBackColor = true;
            this.btnAddAnotherAccount.Click += new System.EventHandler(this.btnAddAnotherAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de Pedido";
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 405);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAnotherAccount);
            this.Controls.Add(this.btnAddFinish);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.numOrderAmount);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "NewCustomer";
            this.Text = "Cuenta y Pedidos Nuevos";
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.NumericUpDown numOrderAmount;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnAddFinish;
        private System.Windows.Forms.Button btnAddAnotherAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
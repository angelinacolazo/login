﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nombre, contraseña;
            nombre = textBox1.Text;
                contraseña = textBox2.Text;
            if(nombre=="juancho"&&contraseña=="123tamarindo")
            {
                MessageBox.Show("hola bienvenido junacho");
            }
            else
            {
                MessageBox.Show("tu no eres juancho no mereces un perrito, bye");
            }


        }
    }
}

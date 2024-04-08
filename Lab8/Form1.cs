using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab8
{
    public partial class Form1 : Form
    {

        List<int> notastemp = new List<int>();
        List<Notas> listanotas = new List<Notas>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt16(textBox2.Text);
            notastemp.Add(nota);
        }

        private void grabar() { 
            string json = JsonConvert.SerializeObject(listanotas);
            string archivo = "Datos.json";
            System.IO.File.WriteAllText(archivo, json);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Notas notasalumno = new Notas();
            notasalumno.Nombre = textBox1.Text;
            notasalumno.NotasA = notastemp;

            listanotas.Add(notasalumno);
            grabar();
            notastemp.Clear();
        }
    }
}

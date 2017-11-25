﻿
using FINALBASES.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALBASES.Interfaz
{
    public partial class FormGestion : Form
    {
        public FormGestion( Datos.Datos datos) 
        {
            InitializeComponent();
            
            initChildren(datos);
        }
        public void initChildren(Datos.Datos datos)
        {
            Diplomado diplomado = new Diplomado(datos);
            Estilista estilista = new Estilista(datos);
            this.childDiplomado = new FromDiplomado(diplomado);
            this.childEstilista = new Interfaz.FormEstilista(estilista);

        }
        private void pasarAForm(Form form)
        {
            this.Visible = false;
            form.ShowDialog(this);
            this.Show();
        }
        public void setModoGestion(string nuevoModo)
        {
            aModoGestion = nuevoModo;
            this.lblModo.Text = "GESTION " + nuevoModo;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form nuevoForm;
            if (this.aModoGestion == MODO_DIPLOMADO)
            {
                this.childDiplomado.setModo(FromDiplomado.MODO_REGISTRAR);
                nuevoForm = this.childDiplomado;
            }
            else
            {
                this.childEstilista.setModo(FromDiplomado.MODO_REGISTRAR);
                nuevoForm = this.childEstilista;
            }
            pasarAForm(nuevoForm);
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form nuevoForm;
            if (this.aModoGestion == MODO_DIPLOMADO)
            {
                this.childDiplomado.setModo(FromDiplomado.MODO_ACTUALIZAR);
                nuevoForm = this.childDiplomado;
            }
            else
            {
                this.childEstilista.setModo(FromDiplomado.MODO_ACTUALIZAR);
                nuevoForm = this.childEstilista;
            }
            pasarAForm(nuevoForm);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form nuevoForm;
            if (this.aModoGestion == MODO_DIPLOMADO)
            {
                this.childDiplomado.setModo(FromDiplomado.MODO_ELIMINAR);
                nuevoForm = this.childDiplomado;
            }
            else
            {
                this.childEstilista.setModo(FromDiplomado.MODO_ELIMINAR);
                nuevoForm = this.childEstilista;
            }
            pasarAForm(nuevoForm);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private FromDiplomado childDiplomado;
        private Interfaz.FormEstilista childEstilista;
        private string aModoGestion = "DIPLOMADO";
        public static string MODO_DIPLOMADO = " DIPLOMADO ";
        public static string MODODO_ESTILISTA = "ESTILISTA";


    }
}
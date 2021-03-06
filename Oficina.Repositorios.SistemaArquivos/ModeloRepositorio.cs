﻿using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class ModeloRepositorio
    {
        private object modeloId;

        XDocument _arquivoXml = XDocument.Load(ConfigurationManager.AppSettings["caminhoArquivomodelo"]);


        public List<Modelo> SelecionarporMarca(int marcaId)
        {

            var modelos = new List<Modelo>();
            
            foreach (var elemento in _arquivoXml.Descendants("modelo"))

            {
                if (marcaId.ToString() == elemento.Element("marcaId").Value)
                {
                    var modelo = new Modelo();
                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Nome = elemento.Element("nome").Value;
                    modelo.Marca = new MarcaRepositorio().Selecionar(marcaId);

                    modelos.Add(modelo);
                }



            }
            return modelos;
        }

        public Modelo Selecionar(int marcaId)
        {

            Modelo modelo = null;

            foreach (var elemento in _arquivoXml.Descendants("modelo"))

            {
                if (modeloId.ToString() == elemento.Element("id").Value)
                {
                    modelo = new Modelo();
                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Nome = elemento.Element("nome").Value;
                    modelo.Marca = new MarcaRepositorio().Selecionar(Convert.ToInt32(elemento.Element("marcaId").Value));

                    break;



                }
            }
            return modelo;

        }
    }
}

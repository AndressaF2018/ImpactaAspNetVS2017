using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class VeiculoRepositorio
    {
        private string _caminhoArquivoVeiculo = ConfigurationManager.AppSettings["caminhoArquivoveiculo"];

        public object CDocument { get; private set; }

        public void Inserir(Veiculo veiculo)
        {
            var veiculos = XDocument.Load(_caminhoArquivoVeiculo);

            var registro = new StringWriter();
            new XmlSerializer(typeof(Veiculo)).Serialize(registro, veiculo);

            veiculos.Root.Add(XElement.Parse(registro.ToString()));
            veiculos.Save(_caminhoArquivoVeiculo);
        }
    }
}

using System.Xml.Serialization;
using ControleDeFuncionarios.Entities;

namespace ControleDeFuncionarios.UseCases;

/// <summary>
/// Classe que define os serviços de funcionário.
/// </summary>
public class FuncionarioUseCase
{
    public void CadastrarFuncionario(Funcionario funcionario)
    {
        //Salvar os dados do funcionário em arquivo XML
        //Serialização de dados
        var xml = new XmlSerializer(typeof(Funcionario));
        
        //Criando o arquivo para salvar os dados
        var writer = new StreamWriter("/Volumes/ssd_Marcus/temp/funcionario.xml");
        
        //Gravar os dados do funcionário no arquivo
        xml.Serialize(writer, funcionario);
        
        //Fechar o arquivo
        writer.Close();
    }
    
    //Método para consultar os funcionários
    public string ConsultarFuncionario()
    {
        var reader = new StreamReader("/Volumes/ssd_Marcus/temp/funcionario.xml");
        var xml = reader.ReadToEnd();
        reader.Close();

        return xml;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceConvertitoreMonete
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IConvertitoreService
    {
        [OperationContract]
        double ConvertireMoneta(double valore, string monetaDa, string monetaA);

    }

    public class Convertitore : IConvertitoreService
    {
        public double ConvertireMoneta(double valore, string monetaDa, string monetaA)
        {
            double tassaDa = OtenereTassaCambio(monetaDa);
            double tassaA = OtenereTassaCambio(monetaA);

            double valoreConvertito = valore * (tassaDa / tassaA);
            
            return valoreConvertito;
            //return valore * OtenereTassaCambio(monetaDa) / OtenereTassaCambio(monetaA);
        }

        private double OtenereTassaCambio (string moneta)
        {
            switch (moneta)
            {
                case "DEM":
                    return 1.955;
                case "ITL":
                    return 1.936;
                case "FRF":
                    return 6.559;
                default:
                    throw new Exception("Moneta non valida");
            }
        }

    }
    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
}

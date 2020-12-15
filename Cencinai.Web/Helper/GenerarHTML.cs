using Cencinai.Logic.Models;
using System.Collections.Generic;
using System.Text;

namespace Cencinai.Web.Helper
{
    public class GenerarHTML
    {
        public static string EstadoNutricionalHtlm(List<EstadoNutricionalModel> listaEstadoNutricional)
        {
            var html = new StringBuilder();        

            try
            {
                html.AppendFormat(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <h2>Estado Nutricional</h2>
                                </br>");

                foreach (var item in listaEstadoNutricional)
                {
                    var nombre = $"{item.Niño.Nombre} {item.Niño.PrimerApellido} {item.Niño.SegundoApellido}";
                    html.AppendFormat(@"
                                      <table style='font-family:arial,sans-serif;border-collapse:collapse;width:90%;'>  
                                        <tr>          
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Nombre</strong></td>     
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Indice Masa Corporal</strong></td>                   
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Talla Edad</strong></td>                             
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Peso Edad</strong></td> 
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Peso Talla</strong></td>    
                                        </tr>    
                                         <tr>          
                                            <td style='border:1px solid #dddddd;text-align: left;padding: 8px;'>{0}</td>     
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{1}</td>                   
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{2}</td>                             
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{3}</td> 
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{4}</td>    
                                        </tr>    
                                      </table>
                                      <br>", nombre, item?.IndiceMasaCorporal, item?.TallaEdad, item?.PesoEdad, item?.PesoTalla);
                }
                          
                html.Append(@"
                            </body>
                        </html>
                        ");
            }
            catch { }

            return html.ToString();
        }

        public static string NivelDesarrolloHtml(List<NivelDesarrolloModel> listaNivelDesarrollo)
        {
            var html = new StringBuilder();

            try
            {
                html.AppendFormat(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <h2>Nivel de Desarrollo</h2>
                                </br>");

                foreach (var item in listaNivelDesarrollo)
                {
                    var nombre = $"{item.Niño.Nombre} {item.Niño.PrimerApellido} {item.Niño.SegundoApellido}";
                    html.AppendFormat(@"
                                      <table style='font-family:arial,sans-serif;border-collapse:collapse;width:90%;'>  
                                        <tr> 
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Nombre</strong></td>
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Motora Gruesa</strong></td>     
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Motora Fina</strong></td>                   
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Cognoscitiva</strong></td>                             
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Lenguaje</strong></td> 
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Socioafectiva</strong></td>  
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Habitos</strong></td>
                                        </tr>    
                                         <tr>          
                                            <td style='border:1px solid #dddddd;text-align: left;padding: 8px;'>{0}</td>     
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{1}</td>                   
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{2}</td>                             
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{3}</td> 
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{4}</td>
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{5}</td> 
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{6}</td> 
                                        </tr>    
                                      </table>
                                      <br>", nombre, item?.MotoraGruesa, item?.MotoraFina, item?.Cognoscitiva, 
                                      item?.Lenguaje, item?.Socioafectiva, item?.Habitos);
                }

                html.Append(@"
                            </body>
                        </html>
                        ");
            }
            catch { }

            return html.ToString();
        }
    }
}

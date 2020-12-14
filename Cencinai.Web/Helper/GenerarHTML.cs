using Cencinai.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cencinai.Web.Helper
{
    public class GenerarHTML
    {
        public static string EstadoNutricionalHtlm(List<EstadoNutricionalModel> listaEstadoNutricional)
        {
            var html = new StringBuilder();
            var indiceMasaNormal = listaEstadoNutricional.Where(x => x.IndiceMasaCorporal == "Normal").Count();
            var indiceMasaObesidad = listaEstadoNutricional.Where(x => x.IndiceMasaCorporal == "Obesidad").Count();
            var indiceMasaSobrepeso = listaEstadoNutricional.Where(x => x.IndiceMasaCorporal == "Sobrepeso").Count();
            var indiceMasaDesnutricion = listaEstadoNutricional.Where(x => x.IndiceMasaCorporal == "Desnutricion").Count();
            var indiceMasaDesnutricionSevera = listaEstadoNutricional.Where(x => x.IndiceMasaCorporal == "DesnutricionSevera").Count();

            var tallaEdadMuyAlto = listaEstadoNutricional.Where(x => x.TallaEdad == "MuyAlto").Count();
            var tallaEdadAlto = listaEstadoNutricional.Where(x => x.TallaEdad == "Alto").Count();
            var tallaEdadNormal = listaEstadoNutricional.Where(x => x.TallaEdad == "Normal").Count();
            var tallaEdadBajoTalla = listaEstadoNutricional.Where(x => x.TallaEdad == "BajoTalla").Count();
            var tallaEdadBajaTallaSevera = listaEstadoNutricional.Where(x => x.TallaEdad == "BajaTallaSevera").Count();

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

                html.AppendFormat(@"
                                      </br></br>
                                      <h3>Sumatoria Indice de Masa Corporal</h3>
                                      </br>
                                      <table style='font-family:arial,sans-serif;border-collapse:collapse;width:80%;'>  
                                        <tr>          
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Obesidad</strong></td>     
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Sobrepeso</strong></td>                   
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Normal</strong></td>                             
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Desnutrición</strong></td> 
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Desnutrición Severa</strong></td>    
                                        </tr>    
                                         <tr>          
                                            <td style='border:1px solid #dddddd;text-align: left;padding: 8px;'>{0}</td>     
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{1}</td>                   
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{2}</td>                             
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{3}</td> 
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{4}</td>    
                                        </tr>    
                                      </table>
                                      <br>", indiceMasaObesidad, indiceMasaSobrepeso, indiceMasaNormal, indiceMasaDesnutricion, indiceMasaDesnutricionSevera);

                html.AppendFormat(@"
                                      </br></br>
                                      <h3>Sumatoria Talla Edad</h3>
                                      </br>
                                      <table style='font-family:arial,sans-serif;border-collapse:collapse;width:80%;'>  
                                        <tr>          
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Muy Alto</strong></td>     
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Alto</strong></td>                   
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Normal</strong></td>                             
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Bajo Talla</strong></td> 
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'><strong>Baja Talla Severa</strong></td>    
                                        </tr>    
                                         <tr>          
                                            <td style='border:1px solid #dddddd;text-align: left;padding: 8px;'>{0}</td>     
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{1}</td>                   
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{2}</td>                             
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{3}</td> 
                                            <td style='border:1px solid #dddddd;text-align:left;padding:8px;'>{4}</td>    
                                        </tr>    
                                      </table>
                                      <br>", tallaEdadMuyAlto, tallaEdadAlto, tallaEdadNormal, tallaEdadBajoTalla, tallaEdadBajaTallaSevera);


                html.Append(@"
                            </body>
                        </html>
                        ");
            }
            catch(Exception ex) { }

            return html.ToString();
        }
    }
}

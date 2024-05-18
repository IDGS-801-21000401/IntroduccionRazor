using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntroduccionRazor.Pages
{
	public class Programa1Model : PageModel
    {
        [BindProperty]
        public double Peso { get; set; }

        [BindProperty]
        public double Altura { get; set; }

        public double IMC { get; set; }
        public string Resultado { get; set; }
        public string Imagen { get; set; }

        public void OnPost()
        {
            IMC = CalcularIMC(Peso, Altura);
            Resultado = ClasificarIMC(IMC);
        }

        private double CalcularIMC(double peso, double altura)
        {
            double alturaMetros = altura / 100.0;
            return peso / (alturaMetros * alturaMetros);
        }


        private string ClasificarIMC(double imc)
        {
            if (imc < 18)
            {
                Imagen = "peso_bajo.jpeg";
                return "Peso Bajo";
            }
            else if (imc >= 18 && imc < 25)
            {
                Imagen = "peso_normal.jpeg";
                return "Peso Normal";
            }
            else if (imc >= 25 && imc < 27)
            {
                Imagen = "sobrepeso.webp";
                return "Sobrepeso";
            }
            else if (imc >= 27 && imc < 30)
            {
                Imagen = "obesidad_tipo1.jpeg";
                return "Obesidad grado I";
            }
            else if (imc >= 30 && imc < 40)
            {
                Imagen = "obesidad_tipo2.jpeg";
                return "Obesidad grado II";
            }
            else
            {
                Imagen = "obesidad_tipo3.jpeg";
                return "Obesidad grado III";
            }
        }
    }
}

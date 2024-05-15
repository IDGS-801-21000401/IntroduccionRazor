using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntroduccionRazor.Pages
{
	public class SumaNumerosModel : PageModel
    {
        //Definimos propiedades
        [BindProperty] //Enlazamos con campo de formulario
        public string numero1 { get; set; } = "";

        [BindProperty] //Enlazamos con campo de formulario
        public string numero2 { get; set; } = "";

        public double resultado;

        public void OnPost()
        {
            double num1 = double.Parse(numero1);
            double num2 = double.Parse(numero2);

            resultado = num1 + num2;
            
            ModelState.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntroduccionRazor.Pages
{
	public class Programa2Model : PageModel
    {
        public string resultado { get; set; }

        public void OnPost(string mensaje, int n, string modo)
        {
            if (modo == "codificar")
            {
                resultado = CodificarMensaje(mensaje, n);
            }
            else if (modo == "decodificar")
            {
                resultado = DecodificarMensaje(mensaje, n);
            }
        }

        private string CodificarMensaje(string mensaje, int n)
        {
            return AplicarCifrado(mensaje, n);
        }

        private string DecodificarMensaje(string mensaje, int n)
        {
            // El descifrado con n es equivalente al cifrado con (26 - n) en este caso
            return AplicarCifrado(mensaje, 26 - n);
        }

        private string AplicarCifrado(string mensaje, int n)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string resultado = "";

            foreach (char c in mensaje)
            {
                if (char.IsLetter(c))
                {
                    int indice = alfabeto.IndexOf(char.ToUpper(c));
                    int nuevoIndice = (indice + n) % 26;
                    char nuevoCaracter = char.IsUpper(c) ? alfabeto[nuevoIndice] : char.ToLower(alfabeto[nuevoIndice]);
                    resultado += nuevoCaracter;
                }
                else
                {
                    resultado += c; // Conservar caracteres que no son letras
                }
            }

            return resultado;
        }
    }
}

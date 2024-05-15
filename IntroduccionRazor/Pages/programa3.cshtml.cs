using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntroduccionRazor.Pages
{
	public class programa3Model : PageModel
    {
        [BindProperty]
        public double a  { get; set; }  = 0;

        [BindProperty]
        public double b { get; set; } = 0;

        [BindProperty]
        public double x { get; set; } = 0;

        [BindProperty]
        public double y { get; set; } = 0;

        [BindProperty]
        public double n { get; set; } = 0;

        public double resultado = 0;

        public void OnPost(int a, int x, int b, int y, int n)
        {
            resultado = (int)Math.Pow(a * x + b * y, n);
        }

        

    }
}

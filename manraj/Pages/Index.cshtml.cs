using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace manraj.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

     public void OnPost()
    {
 
        if (Request.Method.Equals("POST", System.StringComparison.OrdinalIgnoreCase)){

            if(Request.Form["ADD"]=="ADD"){
 
                ViewData["result"]=double.Parse(Request.Form["num1"])+double.Parse(Request.Form["num2"]);
 
        }

        }

         if(Request.Form["SQR"]=="SQR"){
 
                ViewData["result"]=double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num1"]);
 
        }

         if (Request.Form["PWR"] == "PWR")
                {
                    ViewData["result"] = Math.Pow(double.Parse(Request.Form["num1"]), double.Parse(Request.Form["num2"]));
                }
        if(Request.Form["Sub"]=="Sub"){
 
                ViewData["result"]=double.Parse(Request.Form["num1"])-double.Parse(Request.Form["num2"]);
 
            }
         if(Request.Form["MUL"]=="MUL"){
 
                ViewData["result"]=double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num2"]);
 
            }
         if(Request.Form["DIV"]=="DIV"){
 
                ViewData["result"]=double.Parse(Request.Form["num1"])/double.Parse(Request.Form["num2"]);
 
            } 
        if(Request.Form["CUB"]=="CUB"){
 
                ViewData["result"]=double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num1"]);
 
        }           
            
        
            

    }
}

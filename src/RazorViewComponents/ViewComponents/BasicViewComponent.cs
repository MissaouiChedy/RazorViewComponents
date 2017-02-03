using Microsoft.AspNetCore.Mvc;

namespace RazorViewComponents.ViewComponents
{
    public class Holder 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class BasicViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id, string name)
        {
            
            ViewData["SomeData"] = "This string is passed via ViewData";
            /*
             * This returns a ViewResult that represents
             * the rendering of the cshtml template related
             * to this view component
             */
            return View(new Holder{ Id = id, Name= name });
        }
    }
}

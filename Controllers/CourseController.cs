using Microsoft.AspNetCore.Mvc;

namespace basic.Controllers;

public class CourseController : Controller {

    public string Index() {
        return "course/index";
    }

    public string List() {
        return "course/list";
    }
}
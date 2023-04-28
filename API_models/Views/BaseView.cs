using System.Net;
using API_models.Models;

namespace API_models.Views;

public abstract class BaseView
{
    public abstract HttpStatusCode StatusCode { get; set; }
    
    public abstract IModel Model { get; set; }
}
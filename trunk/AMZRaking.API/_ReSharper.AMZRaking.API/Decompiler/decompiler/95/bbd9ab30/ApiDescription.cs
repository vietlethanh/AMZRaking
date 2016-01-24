// Type: System.Web.Http.Description.ApiDescription
// Assembly: System.Web.Http, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: D:\Projects\MySale\trunk\AMZRaking.API\packages\Microsoft.AspNet.WebApi.Core.5.2.3\lib\net45\System.Web.Http.dll

using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;

namespace System.Web.Http.Description
{
  /// <summary>
  /// Describes an API defined by relative URI path and HTTP method.
  /// </summary>
  public class ApiDescription
  {
    /// <summary>
    /// Gets or sets the HTTP method.
    /// </summary>
    /// 
    /// <returns>
    /// The HTTP method.
    /// </returns>
    public HttpMethod HttpMethod { get; set; }

    /// <summary>
    /// Gets or sets the relative path.
    /// </summary>
    /// 
    /// <returns>
    /// The relative path.
    /// </returns>
    public string RelativePath { get; set; }

    /// <summary>
    /// Gets or sets the action descriptor that will handle the API.
    /// </summary>
    /// 
    /// <returns>
    /// The action descriptor.
    /// </returns>
    public HttpActionDescriptor ActionDescriptor { get; set; }

    /// <summary>
    /// Gets or sets the registered route for the API.
    /// </summary>
    /// 
    /// <returns>
    /// The route.
    /// </returns>
    public IHttpRoute Route { get; set; }

    /// <summary>
    /// Gets or sets the documentation of the API.
    /// </summary>
    /// 
    /// <returns>
    /// The documentation.
    /// </returns>
    public string Documentation { get; set; }

    /// <summary>
    /// Gets the supported response formatters.
    /// </summary>
    /// 
    /// <returns>
    /// The supported response formatters.
    /// </returns>
    public Collection<MediaTypeFormatter> SupportedResponseFormatters { get; internal set; }

    /// <summary>
    /// Gets the supported request body formatters.
    /// </summary>
    /// 
    /// <returns>
    /// The supported request body formatters.
    /// </returns>
    public Collection<MediaTypeFormatter> SupportedRequestBodyFormatters { get; internal set; }

    /// <summary>
    /// Gets the parameter descriptions.
    /// </summary>
    /// 
    /// <returns>
    /// The parameter descriptions.
    /// </returns>
    public Collection<ApiParameterDescription> ParameterDescriptions { get; internal set; }

    /// <summary>
    /// Gets or sets the response description.
    /// </summary>
    /// 
    /// <returns>
    /// The response description.
    /// </returns>
    public ResponseDescription ResponseDescription { get; internal set; }

    /// <summary>
    /// Gets the ID. The ID is unique within <see cref="T:System.Web.Http.HttpServer"/>.
    /// </summary>
    /// 
    /// <returns>
    /// The ID.
    /// </returns>
    public string ID
    {
      get
      {
        return (this.HttpMethod != (HttpMethod) null ? this.HttpMethod.Method : string.Empty) + (this.RelativePath ?? string.Empty);
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Web.Http.Description.ApiDescription"/> class.
    /// </summary>
    public ApiDescription()
    {
      this.SupportedRequestBodyFormatters = new Collection<MediaTypeFormatter>();
      this.SupportedResponseFormatters = new Collection<MediaTypeFormatter>();
      this.ParameterDescriptions = new Collection<ApiParameterDescription>();
    }
  }
}

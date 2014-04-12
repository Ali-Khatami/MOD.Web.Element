using System.Text;
using System.Web.Mvc;

namespace MOD.Web.Element.Controllers
{
	/// <summary>
	/// ElementController provides necessary View() methods that allow you to display your IRenderable page views and/or modules.
	/// </summary>
	public abstract class ElementController : Controller
	{
		/// <summary>
		/// Allows you to pass an Element view, generally a layout document but any IRenderable will do. Will return content as
		/// text/html, encdoded in UTF8.
		/// </summary>
		/// <param name="view">
		/// The IRenderable instance you want to render as a page.
		/// </param>
		/// <returns>
		/// Returns Content of view.Render().ToString(). With content type of text/html, encoded in UTF8.
		/// </returns>
		protected ActionResult View(IRenderable view)
		{
			return View(view, "text/html", Encoding.UTF8);
		}

		/// <summary>
		/// Allows you to pass an Element view, generally a layout document but any IRenderable will do. Will return content as
		/// whatever content type you pass, encdoded in UTF8.
		/// </summary>
		/// <param name="view">
		/// The IRenderable instance you want to render as a page.
		/// </param>
		/// <param name="contentType">
		/// The content type you want the page to be served as.
		/// </param>
		/// <returns>
		/// Returns Content of view.Render().ToString(). With content type of whatever you pass, encoded in UTF8
		/// </returns>
		protected ActionResult View(IRenderable view, string contentType)
		{
			return View(view, contentType, Encoding.UTF8);
		}

		/// <summary>
		/// Allows you to pass an Element view, generally a layout document but any IRenderable will do. Will return content as
		/// whatever content type you pass, encoded as whatever you pass.
		/// </summary>
		/// <param name="view">
		/// The IRenderable instance you want to render as a page.
		/// </param>
		/// <param name="contentType">
		/// The content type you want the page to be served as.
		/// </param>
		/// /// <param name="encoding">
		/// The encoding you want to use for the view.
		/// </param>
		/// <returns>
		/// Returns Content of view.Render().ToString(). With content type of whatever you pass, encoded as whatever you pass.
		/// </returns>
		protected ActionResult View(IRenderable view, string contentType, Encoding encoding)
		{
			return Content(view.Render().ToString(), contentType, encoding);
		}
	}
}
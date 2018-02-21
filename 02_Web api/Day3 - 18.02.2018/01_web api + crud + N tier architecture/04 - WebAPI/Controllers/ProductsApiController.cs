using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace JohnBryce
{
    //[EnableCors("http://blabla.com, http://blublu.com", "*", "*")] // אלינו AJAX אישור לאתרים ספציפיים לגלוש

    [EnableCors("*", "*", "*")]
    public class ProductsApiController : ApiController
    {
        private ProductsLogic logic = new ProductsLogic();

        [HttpGet]
        [Route("products")]
        public HttpResponseMessage GetAllProducts()
        {
            try
            {
                List<ProductModel> products = logic.GetAllProducts();
                return Request.CreateResponse(HttpStatusCode.OK, products);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ExceptionHelper.GetInnerMessage(ex));
            }
        }

        [HttpGet]
        [Route("products/{productID}")]
        public HttpResponseMessage GetOneProduct([FromUri]int productID)
        {
            try
            {
                ProductModel product = logic.GetOneProduct(productID);
                return Request.CreateResponse(HttpStatusCode.OK, product);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ExceptionHelper.GetInnerMessage(ex));
            }
        }

        [HttpPost]
        [Route("products")]
        public HttpResponseMessage AddProduct([FromBody]ProductModel productModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    string error = ModelState.Where(ms => ms.Value.Errors.Any()).Select(ms => ms.Value.Errors[0].ErrorMessage).FirstOrDefault();
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, error);
                }

                productModel = logic.AddProduct(productModel);

                return Request.CreateResponse(HttpStatusCode.Created, productModel);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ExceptionHelper.GetInnerMessage(ex));
            }
        }
    }
}

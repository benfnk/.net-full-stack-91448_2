using System.Collections.Generic;
using System.Web.Http;
using System.Linq;
using System.Net.Http;
using System.Net;
using System;

namespace JohnBryce
{
    //קידומת של הכתובת לינק של כל הפונקציות בתוך הקונטרולר הזה
    [RoutePrefix("api/order")]
    public class OrdersApiController : ApiController
    {
        OrdersLogic logic;

        [HttpGet]
        [Route("orders")]   // access link : http://localhost:53093/api/order/orders
        public HttpResponseMessage GetAllOrders()
        {
            using(logic= new OrdersLogic())
            {
                try
                {
                    List<OrderModel> orders = logic.GetAllOrders();
                    return Request.CreateResponse(HttpStatusCode.OK, orders);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ExceptionHelper.GetInnerMessage(ex));
                }
            }
            
        }

        [HttpGet]
        [Route("orders/{orderID}")]
        public HttpResponseMessage GetOneOrder([FromUri]int orderID)
        {
            using (logic = new OrdersLogic())
            {
                try
                {
                    OrderModel order = logic.GetOneOrder(orderID);
                    return Request.CreateResponse(HttpStatusCode.OK, order);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ExceptionHelper.GetInnerMessage(ex));
                }
            }
        }

        [HttpPost]
        [Route("orders")]
        public HttpResponseMessage AddOrder([FromBody]OrderModel orderModel)
        {
            using (logic = new OrdersLogic())
            {
                try
                {
                    //בדיקה האם הפרמטר שעבר לפונקציה בתור מודל עומד בדרישות הואלידציה
                    //BOהגדרות הואלידציה מוגדרות בתוך ה
                    //Data annotation בתור 
                    if (!ModelState.IsValid)
                    {
                        string error = ModelState.Where(ms => ms.Value.Errors.Any()).Select(ms => ms.Value.Errors[0].ErrorMessage).FirstOrDefault();
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, error);
                    }

                    // הולידציה עברה בהצלחה
                    orderModel = logic.AddOrder(orderModel);

                    return Request.CreateResponse(HttpStatusCode.Created, orderModel);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ExceptionHelper.GetInnerMessage(ex));
                }
            }
        }

        [HttpPut]
        [Route("orders/{orderID}")]
        public HttpResponseMessage UpdateOrder([FromUri]int orderID, [FromBody]OrderModel orderModel)
        {
            using (logic = new OrdersLogic())
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        string error = ModelState.Where(ms => ms.Value.Errors.Any()).Select(ms => ms.Value.Errors[0].ErrorMessage).FirstOrDefault();
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, error);
                    }

                    orderModel.id = orderID;
                    orderModel = logic.UpdateOrder(orderModel);

                    return Request.CreateResponse(HttpStatusCode.OK, orderModel);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ExceptionHelper.GetInnerMessage(ex));
                }
            }
        }

        [HttpPatch]
        [Route("orders/{orderID}")]
        public HttpResponseMessage UpdateOrderDate([FromUri]int orderID, [FromBody]OrderModel orderModel)
        {
            using (logic = new OrdersLogic())
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        string error = ModelState.Where(ms => ms.Value.Errors.Any()).Select(ms => ms.Value.Errors[0].ErrorMessage).FirstOrDefault();
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, error);
                    }

                    orderModel.id = orderID;
                    orderModel = logic.UpdateOrderDate(orderModel);

                    return Request.CreateResponse(HttpStatusCode.OK, orderModel);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ExceptionHelper.GetInnerMessage(ex));
                }
            }
        }

        [HttpDelete]
        [Route("orders/{orderID}")]
        public HttpResponseMessage DeleteOrder([FromUri]int orderID)
        {
            using (logic = new OrdersLogic())
            {
                try
                {
                    logic.DeleteOrder(orderID);
                    return Request.CreateResponse(HttpStatusCode.NoContent);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ExceptionHelper.GetInnerMessage(ex));
                }
            }
        }
    }
}

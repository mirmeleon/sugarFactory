﻿//using System.Linq;
//using AutoMapper;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;
//using SugarFactory.Data;
//using SugarFactory.Models.BindingModels.Orders;
//using SugarFactory.Models.EntityModels;
//using SugarFactory.Models.ViewModels.Orders;
//using SugarFactory.Services;
//using SugarFactory.Services.Contracts;
//using SugarFactory.Web.Controllers;
//using TestStack.FluentMVCTesting;

//namespace SugarFactory.Tests
//{
//    [TestClass]
//   public class OrderControllerTests
//    {
//        private OrderController _controller; 
//        private IOrdersService _service;
//        private SugarFactoryContext _context;

//        [TestInitialize]
//        public void Init()
//        {

//            _context = new SugarFactoryContext();
//            this._service = new OrdersService();
//            this._controller = new OrderController(_service);
    
//            ConfigureAutoMapper();
//        }

//        private void ConfigureAutoMapper()
//        {
//            Mapper.Initialize(expression =>
//            {
               
//                expression.CreateMap<Order, OrderViewModel>()
//                   .ForMember(dest => dest.OrderDate,
//                       opt => opt.MapFrom(
//                           src => src.OrderDate.Date.ToString("dd/MM/yyyy")));

//            });
//        }

    
//        [TestMethod]
//        public void EditOrder_ShouldReturn_DefaultViewWithOrderViewModel()
//        {
//            var orderId = this._context.Orders.FirstOrDefault().Id;

//            _controller.WithCallTo(c => c.EditOrder(orderId))
//                .ShouldRenderDefaultView()
//                .WithModel<OrderViewModel>();
//        }

//        [TestMethod]
//        public void EditOrder_ShouldReturn_DefaultViewWithOrderViewModelWithGivenId()
//        {
//            var orderId = this._context.Orders.FirstOrDefault().Id;

//            var fakeModel= new Mock<OrderViewModel>();
//            fakeModel.SetupAllProperties();
//            fakeModel.Object.Id = orderId;

            
//            _controller.WithCallTo(c => c.EditOrder(orderId))
//                .ShouldRenderDefaultView()
//                .WithModel<OrderViewModel>(m=>m.Id == fakeModel.Object.Id);
            
//        }

//        [TestMethod]
//        public void EditOrderFromPostMethodWithWrondModel_ShouldRedirectTo_EditOrderWithGetMethod()
//        {
            
//            var orderId = this._context.Orders.FirstOrDefault().Id;
//            _controller.ModelState.AddModelError("PaperKg", "1");

//            var model = new Mock<EditOrderBm>();
//            model.Object.PaperKg = 1;

//            _controller.WithCallTo(c => c.EditOrder(orderId, model.Object))
//                 .ShouldRedirectTo(c => c.EditOrder(orderId));
             
//        }
      
//    }
//}

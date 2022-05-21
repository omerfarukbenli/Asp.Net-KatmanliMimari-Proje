using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : CustomBaseController //eklediğimiz  controllerı buraya ekliyoruz
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _service; //controllerlar servicleri bilir
        public ProductsController(IMapper mapper, IService<Product> service)
        {
            _service = service;
            _mapper = mapper;   
        }
        //base control oluşturuluyor, dönme işlemi orada gerçekleştiriliyor
        //serviceteki metodları yazıyoruz
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _service.GetAllAsync();
            var productsDtos = _mapper.Map<List<ProductDto>>(products.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));  
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetByIdAsync(id);
            var productsDto = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productsDto));
        }
        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var product = await _service.AddAsync(_mapper.Map<Product>(productDto));
            var productsDto = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(201, productsDto)); //201 created //oluşturuldu
        }
        [HttpPut]
        public async Task<IActionResult> Update(ProductDto productDto) //güncellemede bir şey dönmüyor, no content //product dto yu kullandığımız için createdate gelecek onun gelmesini istemiyorsak productupdatedto kullanabiliriz
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDto));
            
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204)); //204 nocontent
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(product);
           
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }



    }
}

﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerRepository.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                  new ProductFeature { Id = 1, Color = "kırmızı", Height = 100, Width = 200, ProductId = 1 },
                  new ProductFeature { Id = 2, Color = "mavi", Height = 200, Width = 300, ProductId = 2 }//1 nolu product a ait özellikler

                  );
        }
    }
}

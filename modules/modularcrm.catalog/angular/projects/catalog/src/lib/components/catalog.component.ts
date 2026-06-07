import { Component, OnInit, inject } from '@angular/core';
import { ProductDto, ProductService } from '../proxy/modular-crm/catalog';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { CoreModule } from '@abp/ng.core';

@Component({
  selector: 'lib-catalog',
  templateUrl: './catalog.component.html',
  standalone: true,
  imports: [ThemeSharedModule, CoreModule],
})
export class CatalogComponent implements OnInit {
  products: ProductDto[] = [];

  protected readonly productService = inject(ProductService);

  ngOnInit(): void {
    this.productService.getList().subscribe(response => {
      this.products = response;
    });
  }
}

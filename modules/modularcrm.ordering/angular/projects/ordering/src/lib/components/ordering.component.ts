import { Component, OnInit, inject } from '@angular/core';
import { OrderDto, OrderService } from '../proxy/';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { CoreModule } from '@abp/ng.core';

@Component({
  selector: 'lib-ordering',
  templateUrl: './ordering.component.html',
  standalone: true,
  imports: [ThemeSharedModule, CoreModule],
})
export class OrderingComponent implements OnInit {
  orders: OrderDto[] = [];

  protected readonly orderService = inject(OrderService);

  ngOnInit(): void {
    this.orderService.getList().subscribe(response => {
      this.orders = response;
    });
  }
}

import type { OrderState } from './order-state.enum';

export interface OrderCreationDto {
  productId?: string;
  customerName?: string;
}

export interface OrderDto {
  id?: string;
  productId?: string;
  productName?: string;
  customerName?: string;
  state?: OrderState;
}

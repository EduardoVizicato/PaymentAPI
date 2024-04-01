import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PaymentDetailsComponent } from "./payment-details/payment-details.component";
import { PaymentDetailFormComponent } from "./payment-details/payment-detail-form/payment-detail-form.component";

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styles: [],
    imports: [RouterOutlet, PaymentDetailsComponent, PaymentDetailFormComponent]
})
export class AppComponent {
  title = 'PaymentApp';
}

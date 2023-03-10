import { Component, Input } from "@angular/core";
import { Router, RouterLink } from "@angular/router";

@Component({
  selector: 'app-back-button',
  templateUrl: './back-button.component.html'
})
export class BackButtonComponent {
  @Input()
  public buttonText: string = 'Go back';

  @Input()
  public backRouterLink!: string;
}

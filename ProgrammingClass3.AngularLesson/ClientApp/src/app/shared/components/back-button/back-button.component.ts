import { Component, Input } from "@angular/core"

@Component({
  selector: 'app-back-button',
  templateUrl: './back-button.component.html',
})
export class BackButtonComponent {

  @Input()
    public backRouterLink!: string;

  @Input()
  public backText: string = 'Go Back';
}

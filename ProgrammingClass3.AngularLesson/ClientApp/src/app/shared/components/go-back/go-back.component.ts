import { Component, Input } from "@angular/core";


@Component({
  templateUrl: './go-back.component.html',
  selector: 'app-go-back'
})

export class GoBack {
  @Input()
  public goBackText: string = 'Go Back';
}


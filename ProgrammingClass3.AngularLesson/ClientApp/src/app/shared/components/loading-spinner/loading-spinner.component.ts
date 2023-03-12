import { Component, EventEmitter, Input, Output } from "@angular/core";

@Component({
  selector: 'app-loading-spinner',
  templateUrl: './loading-spinner.component.html',
  styleUrls: [
    './loading-spinner.component.css'
  ]
})
export class LoadingSpinnerComponent {
  @Input()
  public spinnerText: string = 'Loading Data...';

  @Input()
  public isVisible: boolean = false;

  @Output()
  public cancel: EventEmitter<void> = new EventEmitter();

  public onCancel(): void {
    this.cancel.emit();
  }
}

import { Component, EventEmitter, Input, Output } from "@angular/core";

@Component({
  templateUrl: './loading-spinner.component.html',
  selector: 'app-loading-spinner'
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

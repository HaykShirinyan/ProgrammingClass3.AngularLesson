import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-back-button',
  templateUrl: './back-button.component.html'
})
export class BackButtonComponent {
  private router: Router;

  @Input()
  public destination: string = "";

  @Input()
  public linkName: string = "";

  constructor(router: Router) {
    this.router = router;
  }

  public goBack(): void {
    this.router.navigate([`${this.destination}`])
  }
}

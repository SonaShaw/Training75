import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  template: `<h2 class="counter">Counter : {{count}}</h2>
  <button class="counter-button" (click)="handleCount()">Click</button>
  `,
  styles: [ `
  .counter-button{
    font-size:1rem;
    padding: 5px 10px;
    color: #585858;
  }
  
  ` ]
})
export class AppComponent  {
  name = 'Angular';
  count:number=42;
  handleCount(){
    this.count++;
  }
}

import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  template: `<p [hidden]="state">{{val}}</p>
  <button (click)="performAction()">{{action}}</button>
  `,
  styles: [ `
  .hide-div{
    font-size:1rem;
    padding: 5px 10px;
    color: #585858;
    display: none;
  }
  .show-div{
    font-weight:bold;
    color:#1565c0;
    display:block
  }
  ` ]
})
export class AppComponent  {
  name = 'Angular';
  action:string="hide";
  val:string = "Hide this paragraph";
  state:boolean=false;
  performAction(){
    if(this.action=="hide"){
      this.action = "show";
      this.state = true;
    }else{
      this.action = "hide";
      this.state=false;
    }
  }

}

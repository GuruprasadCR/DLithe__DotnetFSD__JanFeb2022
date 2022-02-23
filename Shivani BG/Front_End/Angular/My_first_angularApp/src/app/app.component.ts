import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'My_first_angularApp';
  public image="/assets/images/p2.jpg"
  // Two way Bindig
  public value=""
  //event binding
  onClick()
  {
    alert("welcome to Event binding")
  }
}


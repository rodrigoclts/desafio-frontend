import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  styles: [
    `
      .search-results {
        height: 20rem;
        overflow: scroll;
      }
    `,
  ],
  template: `
    <div
      class="search-results"
      infiniteScroll
      [infiniteScrollDistance]="2"
      [infiniteScrollThrottle]="50"
      (scrolled)="onScroll()"
    ></div>
  `,
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css',]
})
export class AppComponent {
  onScroll() {
    console.log('scrolled!!');
  }
}

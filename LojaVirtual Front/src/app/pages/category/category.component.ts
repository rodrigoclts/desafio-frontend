import { Component, OnInit } from '@angular/core';
import {ProductService} from "../../services/products.service";
import {Product} from "../../model/product";
import {CartService} from "../../services/cart.service";
import {Router} from "@angular/router";

@Component({
    selector: 'app-category',
    styles: [
        `
          .search-results {
            height: 10rem;
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
    templateUrl: './category.component.html',
    styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {
    onScroll() {
        console.log('scrolled!!');
      }

    public products:Array<Product>;
    private sub;
    constructor(
         private productService:ProductService,
         private cartService:CartService,
         private router: Router
    ) { }

    ngOnInit() {
        this.load();
    }
    load = () => {
        this.sub = this.productService.getProducts2()
             .subscribe(res => {
                 this.products = res;
             })
     };

    addToCart = (product) => {
        this.cartService.addToCart({product,quantity:1})
    };

    ngOnDestroy() {
        this.sub.unsubscribe();
    }
}

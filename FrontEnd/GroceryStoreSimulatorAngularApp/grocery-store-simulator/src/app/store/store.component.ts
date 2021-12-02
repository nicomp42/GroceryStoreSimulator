import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Store, StoreService } from './store.service';

@Component({
  templateUrl: './store.component.html',
  styleUrls: ['./store.component.css']
})
export class StoreComponent implements OnInit {

   stores: Observable<Store[]>;

  constructor(private storeService: StoreService) {
  
    this.stores = this.storeService.getStores();

  }

  ngOnInit(): void {
  }

}

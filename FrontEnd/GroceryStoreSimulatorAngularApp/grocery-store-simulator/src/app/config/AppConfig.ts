import { Injectable } from "@angular/core";

@Injectable()
export class AppConfig{
    get apiRootUrl(){
        return 'https://localhost:7258/api'
    }
}
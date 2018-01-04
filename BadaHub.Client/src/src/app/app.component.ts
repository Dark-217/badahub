import {Component, HostListener, ViewEncapsulation} from '@angular/core';
import { OnInit } from '@angular/core/src/metadata/lifecycle_hooks';
import { Platform } from 'ionic-angular';
import { StatusBar } from '@ionic-native/status-bar';
import { SplashScreen } from '@ionic-native/splash-screen';
import { HubConnection } from '@aspnet/signalr-client';

import { TabsPage } from '../pages/tabs/tabs';

@Component({
  templateUrl: 'app.html',
  encapsulation: ViewEncapsulation.None
})
export class MyApp implements OnInit {
  rootPage:any = TabsPage;
  connection: HubConnection;

  constructor(platform: Platform, statusBar: StatusBar, splashScreen: SplashScreen) {
    platform.ready().then(() => {
      // Okay, so the platform is ready and our plugins are available.
      // Here you can do any higher level native things you might need.
      statusBar.styleDefault();
      splashScreen.hide();
    });
  }

  ngOnInit(){

      this.connection = new HubConnection('http://localhost:52858/main');
      this.connection.on("broadcastMessage", function(message){
         console.log(message);
      });
      this.connection.start()
          .then(() => {
              console.log('Hub connection started')
          })
          .catch(err => {
              console.log('Error while establishing connection')
          });
  }


    @HostListener('window:beforeunload')
    doSomething() {
      this.connection.stop();
    }


}


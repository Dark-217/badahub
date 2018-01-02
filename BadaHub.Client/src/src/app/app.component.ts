import {Component, ViewEncapsulation} from '@angular/core';
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

  constructor(platform: Platform, statusBar: StatusBar, splashScreen: SplashScreen) {
    platform.ready().then(() => {
      // Okay, so the platform is ready and our plugins are available.
      // Here you can do any higher level native things you might need.
      statusBar.styleDefault();
      splashScreen.hide();
    });
  }

  ngOnInit(){

      const connection = new HubConnection('http://localhost:52858/main');
      connection.on("send", function(){
         console.log("message");
      });
      connection.start()
          .then(() => {
              console.log('Hub connection started')
          })
          .catch(err => {
              console.log('Error while establishing connection')
          });
  }
}

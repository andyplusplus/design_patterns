//http://java.dzone.com/articles/design-patterns-command
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2_Commands_LightSwitch {
    class MainApp {
        public static void Main1() {
            RemoteControl control = new RemoteControl();
            Light light = new Light();
            Command lightsOn = new LightOnCommand(light);
            Command lightsOff = new LightOffCommand(light);
            //switch on
            control.setCommand(lightsOn);
            control.pressButton();
            //switch off
            control.setCommand(lightsOff);
            control.pressButton();
        }
    }

    #region Command
    interface Command {
        void execute();
    }

    //Concrete Command
    class LightOnCommand : Command {
        //reference to the light
        Light light; 
        public LightOnCommand(Light light) {
            this.light = light;
        } 
        public void execute() {
            light.switchOn();
        } 
    }
 

    //Concrete Command
    class LightOffCommand : Command {
        //reference to the light
        Light light; 
        public LightOffCommand(Light light) {
            this.light = light;
        } 
        public void execute() {
            light.switchOff();
        } 
    }
    #endregion

    //Invoker
    class RemoteControl {
        private Command command;
        public void setCommand(Command command) {
            this.command = command;
        }
        public void pressButton() {
            command.execute();
        }
    }

    //Receiver
    public class Light {
        private bool on;  
        public void switchOn() {
            on = true;
        } 
        public void switchOff() {
            on = false;
        }  
    }

}

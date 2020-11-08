# Smart home (Smart mower)

## Main idea

We are developers of a smart device that we will sell to homes (it can also be used for industrial purposes) all over the world. Imagine a smart device that we will sell to users.

With the aim of unified and secure access to the device, we want to create an intermediate layer with the help of web services, through which controlled communication by external clients will be enabled. Such a communication pattern is otherwise called service-assisted communication.

## Task

Design and implement web services for fictional devices through which you can monitor and control all devices and their sensors.

Define messages in the services that you define in principle, but still contain at least:

- Device information (device name, manufacturer, unique device number, status - on / off),
- data on sensors / modules on the device (unique number, name / purpose, unit), and
- data from sensors / modules (timestamp, value).

Support the following operations to communicate with external clients:

- an operation that will return status data (on / off) for each device,
- an operation that allowed the state of the devices to be set,
- an operation that will return sensor / module data for each device, and
- an operation that will return data from a specific sensor OR an operation that will control the module.

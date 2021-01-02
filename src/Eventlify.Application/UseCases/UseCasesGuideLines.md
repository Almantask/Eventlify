# Use Cases Guidelines

## 1 - **Don't Use** Them If It Just Proxies A Handler

If a use case is just a plain crud without anything in between (simply calls a handler) - don't use a use case object - use a handler immediately.
Don't use them in this case because it's unneeded overhead.

## 2 - **Use Them** If It Involves Multiple App Components

App components are: services, handlers, other... As long as it is something that is either an abstraction or belongs to App tier or lower.
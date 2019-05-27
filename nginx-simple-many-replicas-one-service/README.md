# Getting Started
Install Kubernates and have `KubeCtl`

# Running

## Namespaces
`kubectl apply -f .\namespaces\dv1.yaml`
`kubectl apply -f .\namespaces\prd.yaml`

`kubectl get namespace` - Shows newly created namespaces

## Services
`kubectl apply -f .\services\nginx.service.yaml --namespace=nginx-simple-dv1`
`kubectl apply -f .\services\nginx.service.yaml --namespace=nginx-simple-prd`

` kubectl get service --namespace=nginx-simple-dv1` - Shows newly created services on dv1 namespace (localhost:8080 to access) - will now have different host names on requests

## Deployments
`kubectl apply -f .\deployments\nginx.deployment.yaml  --namespace=nginx-simple-dv1`
`kubectl apply -f .\deployments\nginx.deployment.yaml  --namespace=nginx-simple-prd`

`kubectl get deployments --namespace=nginx-simple-dv1` - Shows newly created deployments on dv1 namespace (localhost:8081 to access)
infracost breakdown --path .

terraform apply -auto-approve

dotnet aspnet-codegenerator Controller -name UrlMappingController -m UrlMapping -dc ShortContext -outDir Controllers -udl

az webapp deployment list-publishing-profiles --name upt-awa-113 --resource-group upt-arg-113 --xml


zip -r deploy.zip .

az webapp deploy --resource-group upt-arg-113 --name upt-awa-113 --src-path deploy.zip --clean true --restart true --debug


az monitor metrics list --resource "/subscriptions/1f57de72-50fd-4271-8ab9-3fc129f02bc0/resourceGroups/UPT/providers/Microsoft.Web/sites/appblazor0001" --metric "Requests" --start-time 2025-01-07T18:00:00Z --end-time 2025-01-07T23:00:00Z --output table


```mermaid
flowchart TD
    subgraph Terraform
        azurerm_linux_web_app_webapp["azurerm_linux_web_app.webapp"]
        azurerm_resource_group_rg["azurerm_resource_group.rg"]
        azurerm_service_plan_appserviceplan["azurerm_service_plan.appserviceplan"]
        random_integer_ri["random_integer.ri"]
    end
    azurerm_linux_web_app_webapp --> azurerm_service_plan_appserviceplan
    azurerm_resource_group_rg --> random_integer_ri
    azurerm_service_plan_appserviceplan --> azurerm_resource_group_rg
```

![Alt text](./inframap_azure.svg)
<img src="./inframap_azure.svg">
